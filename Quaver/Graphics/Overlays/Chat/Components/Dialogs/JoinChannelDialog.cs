﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Quaver.Assets;
using Quaver.Helpers;
using Quaver.Online.Chat;
using Wobble.Graphics;
using Wobble.Graphics.BitmapFonts;
using Wobble.Graphics.Sprites;
using Wobble.Graphics.Transformations;
using Wobble.Graphics.UI.Dialogs;
using Wobble.Input;

namespace Quaver.Graphics.Overlays.Chat.Components.Dialogs
{
    public class JoinChannelDialog : DialogScreen
    {
        /// <summary>
        ///     Reference to the chat overlay dialog.
        /// </summary>
        private ChatOverlay Overlay { get; }

        /// <summary>
        ///     The actual content of the interface
        /// </summary>
        private Sprite InterfaceContainer { get; set; }

        /// <summary>
        ///     The container for the header of the interface.
        /// </summary>
        private Sprite HeaderContainer { get; set; }

        /// <summary>
        ///     The scroll container which houses all of the chat channels.
        /// </summary>
        public ScrollContainer ChannelContainer { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public JoinChannelDialog(ChatOverlay overlay) : base(0)
        {
            Overlay = overlay;
            SpriteBatchOptions = new SpriteBatchOptions() {BlendState = BlendState.NonPremultiplied};
            CreateContent();

            Clicked += (sender, args) =>
            {
                if (!GraphicsHelper.RectangleContains(InterfaceContainer.ScreenRectangle,
                    MouseManager.CurrentState.Position))
                {
                    ChatManager.Dialog.CloseJoinChannelDialog();
                }
            };
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public sealed override void CreateContent()
        {
            CreateInterfaceContainer();
            CreateHeaderContainer();
            CreateChannelContainer();
            AddChannels();
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="gameTime"></param>
        public override void HandleInput(GameTime gameTime)
        {
            if (KeyboardManager.IsUniqueKeyPress(Keys.Escape))
                Overlay.CloseJoinChannelDialog();
        }

        /// <summary>
        ///     Creates the container for the entire dialog.
        /// </summary>
        private void CreateInterfaceContainer() => InterfaceContainer = new Sprite()
        {
            Parent = this,
            Alignment = Alignment.BotLeft,
            SetChildrenAlpha = true,
            Size = new ScalableVector2(Width, 400),
            Tint = new Color(63, 68, 91),
            Y = 400,
            Alpha = 0,
            Transformations =
            {
                new Transformation(TransformationProperty.Alpha, Easing.Linear, 0, 1, 400),
                new Transformation(TransformationProperty.Y, Easing.EaseOutQuint, 400, 0, 800)
            },
            UsePreviousSpriteBatchOptions = true
        };

        /// <summary>
        ///     Creates the header container for the interface.
        /// </summary>
        private void CreateHeaderContainer()
        {
            HeaderContainer = new Sprite()
            {
                Parent = InterfaceContainer,
                Size = new ScalableVector2(Width, 75),
                Tint = Colors.DarkGray,
                UsePreviousSpriteBatchOptions = true
            };

            var line = new Sprite()
            {
                Parent = HeaderContainer,
                Alignment = Alignment.BotLeft,
                Size = new ScalableVector2(HeaderContainer.Width, 2),
                UsePreviousSpriteBatchOptions = true,
                Tint = Colors.MainAccent
            };

            var icon = new Sprite()
            {
                Parent = HeaderContainer,
                Alignment = Alignment.MidLeft,
                X = 25,
                Size = new ScalableVector2(HeaderContainer.Height * 0.50f, HeaderContainer.Height * 0.50f),
                Image = FontAwesome.Group,
                UsePreviousSpriteBatchOptions = true
            };

            var chatChannels = new SpriteTextBitmap(BitmapFonts.Exo2SemiBold, "Join Chat Channels", 24, Color.White,
                Alignment.MidLeft, int.MaxValue)
            {
                Parent = icon,
                Y = -3,
                X = icon.Width + 15,
                UsePreviousSpriteBatchOptions = true
            };

            chatChannels.Size = new ScalableVector2(chatChannels.Width * 0.60f, chatChannels.Height * 0.60f);

            var description = new SpriteTextBitmap(BitmapFonts.Exo2Medium, "Channels are divided into individual chat topics. Join one! What are you waiting for?",
                24, Color.White, Alignment.MidLeft, int.MaxValue)
            {
                Parent = icon,
                Y = chatChannels.Y + chatChannels.Height - 2,
                X = icon.Width + 15,
                UsePreviousSpriteBatchOptions = true
            };

            description.Size = new ScalableVector2(description.Width * 0.50f, description.Height * 0.50f);
        }

        /// <summary>
        ///     Creates the ScrollContainer that displays the chat channels.
        /// </summary>
        private void CreateChannelContainer()
        {
            var size = new ScalableVector2(Width, InterfaceContainer.Height - HeaderContainer.Height);
            ChannelContainer = new ScrollContainer(size, size)
            {
                Parent = InterfaceContainer,
                Y = HeaderContainer.Height,
                Alpha = 0,
                InputEnabled = true,
                ScrollSpeed = 150,
                EasingType = Easing.EaseOutQuint,
                TimeToCompleteScroll = 1500,
                Scrollbar =
                {
                    Tint = Color.White,
                    Width = 3,
                }
            };
        }

        /// <summary>
        ///    Adds all the available channels to the dialog container.
        /// </summary>
        private void AddChannels()
        {
            lock (ChatManager.AvailableChatChannels)
            {
                for (var i = 0; i < ChatManager.AvailableChatChannels.Count; i++)
                {
                    var chan = ChatManager.AvailableChatChannels[i];

                    var availableChannel = new AvailableChannel(chan, this)
                    {
                        Y = AvailableChannel.HEIGHT * i
                    };

                    availableChannel.Y += (i + 1) * 10;

                    ChannelContainer.AddContainedDrawable(availableChannel);
                }

                var totalHeight = ChatManager.AvailableChatChannels.Count * AvailableChannel.HEIGHT + ((ChatManager.AvailableChatChannels.Count + 1) * 10);

                if (totalHeight > ChannelContainer.Height)
                    ChannelContainer.ContentContainer.Height = totalHeight - 1;
            }
        }
    }
}