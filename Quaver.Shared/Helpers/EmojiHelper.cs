using System.Collections.Generic;

namespace Quaver.Shared.Helpers
{
    public static class EmojiHelper
    {
        public static Dictionary<string, int> Emojis = new Dictionary<string, int>()
        {
            {":100:",0x1f4a},
            {":+1:",0x1f44d},
            {":1st_place_medal:",0x1f947},
            {":3rd_place_medal:",0x1f949},
            {":a:",0x1f170},
            {":abc:",0x1f524},
            {":accept:",0x1f251},
            {":airplane:",0x2708},
            {":alarm_clock:",0x23f0},
            {":alembic:",0x2697},
            {":alien:",0x1f47d},
            {":amphora:",0x1f3fa},
            {":angel:",0x1f47c},
            {":angry:",0x1f620},
            {":anguished:",0x1f627},
            {":apple:",0x1f34e},
            {":aries:",0x2648},
            {":arrow_backward:",0x25c0},
            {":arrow_double_up:",0x23eb},
            {":arrow_down_small:",0x1f53d},
            {":arrow_heading_down:",0x2935},
            {":arrow_left:",0x2b05},
            {":arrow_lower_right:",0x2198},
            {":arrow_right_hook:",0x21aa},
            {":arrow_up_down:",0x2195},
            {":arrow_upper_left:",0x2196},
            {":arrows_clockwise:",0x1f503},
            {":art:",0x1f3a8},
            {":artificial_satellite:",0x1f6f0},
            {":astonished:",0x1f632},
            {":atm:",0x1f3e7},
            {":atom_symbol:",0x269b},
            {":avocado:",0x1f951},
            {":b:",0x1f171},
            {":baby_bottle:",0x1f37c},
            {":baby_symbol:",0x1f6bc},
            {":bacon:",0x1f953},
            {":baggage_claim:",0x1f6c4},
            {":balance_scale:",0x2696},
            {":ballot_box:",0x1f5f3},
            {":bamboo:",0x1f38d},
            {":bangbang:",0x203c},
            {":bank:",0x1f3e6},
            {":barber:",0x1f488},
            {":basketball:",0x1f3c0},
            {":bat:",0x1f987},
            {":bathtub:",0x1f6c1},
            {":beach_umbrella:",0x1f3d6},
            {":bed:",0x1f6cf},
            {":beer:",0x1f37a},
            {":beetle:",0x1f41e},
            {":bell:",0x1f514},
            {":bento:",0x1f371},
            {":bicyclist:",0x1f6b4},
            {":biking_man:",0x1f6b4},
            {":bikini:",0x1f459},
            {":bird:",0x1f426},
            {":black_circle:",0x26ab},
            {":black_heart:",0x1f5a4},
            {":black_large_square:",0x2b1b},
            {":black_medium_square:",0x25fc},
            {":black_small_square:",0x25aa},
            {":blonde_man:",0x1f471},
            {":blossom:",0x1f33c},
            {":blue_book:",0x1f4d8},
            {":blue_heart:",0x1f499},
            {":boar:",0x1f417},
            {":bomb:",0x1f4a3},
            {":bookmark:",0x1f516},
            {":books:",0x1f4da},
            {":boot:",0x1f462},
            {":bouquet:",0x1f490},
            {":bow_and_arrow:",0x1f3f9},
            {":bowling:",0x1f3b3},
            {":boxing_glove:",0x1f94a},
            {":bread:",0x1f35e},
            {":bridge_at_night:",0x1f309},
            {":broken_heart:",0x1f494},
            {":bug:",0x1f41b},
            {":bulb:",0x1f4a1},
            {":bullettrain_front:",0x1f685},
            {":burrito:",0x1f32f},
            {":bus:",0x1f68c},
            {":busstop:",0x1f68f},
            {":busts_in_silhouette:",0x1f465},
            {":cactus:",0x1f335},
            {":calendar:",0x1f4c6},
            {":calling:",0x1f4f2},
            {":camel:",0x1f42b},
            {":camera_flash:",0x1f4f8},
            {":camping:",0x1f3d5},
            {":cancer:",0x264b},
            {":candy:",0x1f36c},
            {":capital_abcd:",0x1f520},
            {":car:",0x1f697},
            {":card_index:",0x1f4c7},
            {":carousel_horse:",0x1f3a0},
            {":cat:",0x1f431},
            {":cd:",0x1f4bf},
            {":chains:",0x26d3},
            {":chart:",0x1f4b9},
            {":chart_with_upwards_trend:",0x1f4c8},
            {":cheese:",0x1f9c0},
            {":cherry_blossom:",0x1f338},
            {":chicken:",0x1f414},
            {":chipmunk:",0x1f43f},
            {":christmas_tree:",0x1f384},
            {":cinema:",0x1f3a6},
            {":city_sunrise:",0x1f307},
            {":cityscape:",0x1f3d9},
            {":clamp:",0x1f5dc},
            {":clapper:",0x1f3ac},
            {":clinking_glasses:",0x1f942},
            {":clock1:",0x1f550},
            {":clock1030:",0x1f565},
            {":clock1130:",0x1f566},
            {":clock1230:",0x1f567},
            {":clock2:",0x1f551},
            {":clock3:",0x1f552},
            {":clock4:",0x1f553},
            {":clock5:",0x1f554},
            {":clock6:",0x1f555},
            {":clock7:",0x1f556},
            {":clock8:",0x1f557},
            {":clock9:",0x1f558},
            {":closed_book:",0x1f4d5},
            {":closed_umbrella:",0x1f302},
            {":cloud_with_lightning:",0x1f329},
            {":cloud_with_rain:",0x1f327},
            {":clown_face:",0x1f921},
            {":cocktail:",0x1f378},
            {":coffee:",0x2615},
            {":cold_sweat:",0x1f630},
            {":comet:",0x2604},
            {":computer:",0x1f4bb},
            {":confetti_ball:",0x1f38a},
            {":confused:",0x1f615},
            {":congratulations:",0x3297},
            {":construction_worker:",0x1f477},
            {":control_knobs:",0x1f39b},
            {":cookie:",0x1f36a},
            {":cop:",0x1f46e},
            {":corn:",0x1f33d},
            {":couch_and_lamp:",0x1f6cb},
            {":couple_with_heart:",0x1f491},
            {":couple_with_heart_woman_man:",0x1f491},
            {":couplekiss_man_woman:",0x1f48f},
            {":cow:",0x1f42e},
            {":cowboy_hat_face:",0x1f920},
            {":crayon:",0x1f58d},
            {":crescent_moon:",0x1f319},
            {":crocodile:",0x1f40a},
            {":crossed_fingers:",0x1f91e},
            {":crossed_swords:",0x2694},
            {":cry:",0x1f622},
            {":crystal_ball:",0x1f52e},
            {":cucumber:",0x1f952},
            {":curly_loop:",0x27b0},
            {":curry:",0x1f35b},
            {":customs:",0x1f6c3},
            {":dagger:",0x1f5e1},
            {":dancers:",0x1f46f},
            {":dancing_women:",0x1f46f},
            {":dark_sunglasses:",0x1f576},
            {":dash:",0x1f4a8},
            {":deciduous_tree:",0x1f333},
            {":department_store:",0x1f3ec},
            {":desert:",0x1f3dc},
            {":desktop_computer:",0x1f5a5},
            {":diamond_shape_with_a_dot_inside:",0x1f4a0},
            {":disappointed:",0x1f61e},
            {":dizzy:",0x1f4ab},
            {":do_not_litter:",0x1f6af},
            {":dog2:",0x1f415},
            {":dolls:",0x1f38e},
            {":door:",0x1f6aa},
            {":dove:",0x1f54a},
            {":dragon_face:",0x1f432},
            {":dromedary_camel:",0x1f42a},
            {":droplet:",0x1f4a7},
            {":duck:",0x1f986},
            {":e-mail:",0x1f4e7},
            {":ear:",0x1f442},
            {":earth_africa:",0x1f30d},
            {":earth_asia:",0x1f30f},
            {":egg:",0x1f95a},
            {":eight_pointed_black_star:",0x2734},
            {":electric_plug:",0x1f50c},
            {":elephant:",0x1f418},
            {":end:",0x1f51a},
            {":envelope_with_arrow:",0x1f4e9},
            {":euro:",0x1f4b6},
            {":european_post_office:",0x1f3e4},
            {":evergreen_tree:",0x1f332},
            {":expressionless:",0x1f611},
            {":eyeglasses:",0x1f453},
            {":face_with_head_bandage:",0x1f915},
            {":facepunch:",0x1f44a},
            {":fallen_leaf:",0x1f342},
            {":family_man_woman_boy:",0x1f46a},
            {":fast_forward:",0x23e9},
            {":fearful:",0x1f628},
            {":feet:",0x1f43e},
            {":ferris_wheel:",0x1f3a1},
            {":field_hockey:",0x1f3d1},
            {":file_cabinet:",0x1f5c4},
            {":film_projector:",0x1f4fd},
            {":fire:",0x1f525},
            {":fireworks:",0x1f386},
            {":first_quarter_moon_with_face:",0x1f31b},
            {":fish_cake:",0x1f365},
            {":fist:",0x270a},
            {":fist_oncoming:",0x1f44a},
            {":fist_right:",0x1f91c},
            {":flags:",0x1f38f},
            {":fleur_de_lis:",0x269c},
            {":flight_departure:",0x1f6eb},
            {":floppy_disk:",0x1f4be},
            {":flushed:",0x1f633},
            {":foggy:",0x1f301},
            {":footprints:",0x1f463},
            {":fountain:",0x26f2},
            {":four_leaf_clover:",0x1f340},
            {":framed_picture:",0x1f5bc},
            {":fried_egg:",0x1f373},
            {":fries:",0x1f35f},
            {":frowning:",0x1f626},
            {":frowning_woman:",0x1f64d},
            {":fuelpump:",0x26fd},
            {":full_moon_with_face:",0x1f31d},
            {":game_die:",0x1f3b2},
            {":gear:",0x2699},
            {":gemini:",0x264a},
            {":ghost:",0x1f47b},
            {":gift:",0x1f381},
            {":girl:",0x1f467},
            {":goal_net:",0x1f945},
            {":golf:",0x26f3},
            {":gorilla:",0x1f98d},
            {":green_apple:",0x1f34f},
            {":green_heart:",0x1f49a},
            {":grey_exclamation:",0x2755},
            {":grimacing:",0x1f62c},
            {":grinning:",0x1f600},
            {":guardsman:",0x1f482},
            {":guitar:",0x1f3b8},
            {":haircut:",0x1f487},
            {":haircut_woman:",0x1f487},
            {":hamburger:",0x1f354},
            {":hammer_and_pick:",0x2692},
            {":hamster:",0x1f439},
            {":handbag:",0x1f45c},
            {":hankey:",0x1f4a9},
            {":hatched_chick:",0x1f425},
            {":headphones:",0x1f3a7},
            {":heart:",0x2764},
            {":heart_eyes:",0x1f60d},
            {":heartbeat:",0x1f493},
            {":hearts:",0x2665},
            {":heavy_division_sign:",0x2797},
            {":heavy_exclamation_mark:",0x2757},
            {":heavy_minus_sign:",0x2796},
            {":heavy_plus_sign:",0x2795},
            {":herb:",0x1f33f},
            {":high_brightness:",0x1f506},
            {":hocho:",0x1f52a},
            {":honey_pot:",0x1f36f},
            {":horse:",0x1f434},
            {":hospital:",0x1f3e5},
            {":hotdog:",0x1f32d},
            {":hotsprings:",0x2668},
            {":hourglass_flowing_sand:",0x23f3},
            {":house_with_garden:",0x1f3e1},
            {":hugs:",0x1f917},
            {":hushed:",0x1f62f},
            {":ice_hockey:",0x1f3d2},
            {":icecream:",0x1f366},
            {":id:",0x1f194},
            {":imp:",0x1f47f},
            {":incoming_envelope:",0x1f4e8},
            {":information_desk_person:",0x1f481},
            {":innocent:",0x1f607},
            {":iphone:",0x1f4f1},
            {":izakaya_lantern:",0x1f3ee},
            {":japan:",0x1f5fe},
            {":japanese_goblin:",0x1f47a},
            {":jeans:",0x1f456},
            {":joy:",0x1f602},
            {":joystick:",0x1f579},
            {":kaaba:",0x1f54b},
            {":key:",0x1f511},
            {":keycap_ten:",0x1f51f},
            {":kimono:",0x1f458},
            {":kiss:",0x1f48b},
            {":kissing_cat:",0x1f63d},
            {":kissing_heart:",0x1f618},
            {":kiwi_fruit:",0x1f95d},
            {":koala:",0x1f428},
            {":label:",0x1f3f7},
            {":large_blue_circle:",0x1f535},
            {":large_orange_diamond:",0x1f536},
            {":last_quarter_moon_with_face:",0x1f31c},
            {":laughing:",0x1f606},
            {":ledger:",0x1f4d2},
            {":left_right_arrow:",0x2194},
            {":lemon:",0x1f34b},
            {":leopard:",0x1f406},
            {":level_slider:",0x1f39a},
            {":libra:",0x264e},
            {":light_rail:",0x1f688},
            {":lion:",0x1f981},
            {":lipstick:",0x1f484},
            {":lizard:",0x1f98e},
            {":lock_with_ink_pen:",0x1f50f},
            {":loop:",0x27bf},
            {":loudspeaker:",0x1f4e2},
            {":love_letter:",0x1f48c},
            {":lying_face:",0x1f925},
            {":mag:",0x1f50d},
            {":mahjong:",0x1f004},
            {":mailbox_closed:",0x1f4ea},
            {":mailbox_with_no_mail:",0x1f4ed},
            {":male_detective:",0x1f575},
            {":man:",0x1f468},
            {":man_dancing:",0x1f57a},
            {":man_in_tuxedo:",0x1f935},
            {":man_with_gua_pi_mao:",0x1f472},
            {":mandarin:",0x1f34a},
            {":mantelpiece_clock:",0x1f570},
            {":martial_arts_uniform:",0x1f94b},
            {":mask:",0x1f637},
            {":massage_woman:",0x1f486},
            {":meat_on_bone:",0x1f356},
            {":medal_sports:",0x1f3c5},
            {":melon:",0x1f348},
            {":menorah:",0x1f54e},
            {":metal:",0x1f918},
            {":microphone:",0x1f3a4},
            {":middle_finger:",0x1f595},
            {":milky_way:",0x1f30c},
            {":minidisc:",0x1f4bd},
            {":money_mouth_face:",0x1f911},
            {":moneybag:",0x1f4b0},
            {":monkey:",0x1f412},
            {":monorail:",0x1f69d},
            {":moon:",0x1f314},
            {":mortar_board:",0x1f393},
            {":motor_boat:",0x1f6e5},
            {":motorcycle:",0x1f3cd},
            {":mount_fuji:",0x1f5fb},
            {":mountain_bicyclist:",0x1f6b5},
            {":mountain_cableway:",0x1f6a0},
            {":mountain_snow:",0x1f3d4},
            {":mouse2:",0x1f401},
            {":moyai:",0x1f5ff},
            {":mrs_claus:",0x1f936},
            {":mushroom:",0x1f344},
            {":musical_note:",0x1f3b5},
            {":mute:",0x1f507},
            {":nail_care:",0x1f485},
            {":national_park:",0x1f3de},
            {":nauseated_face:",0x1f922},
            {":necktie:",0x1f454},
            {":nerd_face:",0x1f913},
            {":neutral_face:",0x1f610},
            {":new_moon:",0x1f311},
            {":newspaper:",0x1f4f0},
            {":next_track_button:",0x23ed},
            {":ng_woman:",0x1f645},
            {":night_with_stars:",0x1f303},
            {":no_bell:",0x1f515},
            {":no_entry:",0x26d4},
            {":no_good:",0x1f645},
            {":no_good_woman:",0x1f645},
            {":no_mouth:",0x1f636},
            {":no_smoking:",0x1f6ad},
            {":nose:",0x1f443},
            {":notebook_with_decorative_cover:",0x1f4d4},
            {":nut_and_bolt:",0x1f529},
            {":o2:",0x1f17e},
            {":octopus:",0x1f419},
            {":office:",0x1f3e2},
            {":ok:",0x1f197},
            {":ok_woman:",0x1f646},
            {":older_man:",0x1f474},
            {":om:",0x1f549},
            {":on:",0x1f51b},
            {":oncoming_bus:",0x1f68d},
            {":oncoming_taxi:",0x1f696},
            {":open_book:",0x1f4d6},
            {":open_hands:",0x1f450},
            {":open_umbrella:",0x2602},
            {":orange:",0x1f34a},
            {":orthodox_cross:",0x2626},
            {":owl:",0x1f989},
            {":package:",0x1f4e6},
            {":page_with_curl:",0x1f4c3},
            {":paintbrush:",0x1f58c},
            {":palm_tree:",0x1f334},
            {":pancakes:",0x1f95e},
            {":paperclip:",0x1f4ce},
            {":parasol_on_ground:",0x26f1},
            {":part_alternation_mark:",0x303d},
            {":passenger_ship:",0x1f6f3},
            {":pause_button:",0x23f8},
            {":peace_symbol:",0x262e},
            {":peanuts:",0x1f95c},
            {":pen:",0x1f58a},
            {":pencil2:",0x270f},
            {":pensive:",0x1f614},
            {":persevere:",0x1f623},
            {":person_frowning:",0x1f64d},
            {":person_with_pouting_face:",0x1f64e},
            {":phone:",0x260e},
            {":pig:",0x1f437},
            {":pig_nose:",0x1f43d},
            {":pineapple:",0x1f34d},
            {":pisces:",0x2653},
            {":pizza:",0x1f355},
            {":plate_with_cutlery:",0x1f37d},
            {":point_down:",0x1f447},
            {":point_right:",0x1f449},
            {":point_up_2:",0x1f446},
            {":police_car:",0x1f693},
            {":poodle:",0x1f429},
            {":popcorn:",0x1f37f},
            {":post_office:",0x1f3e3},
            {":postbox:",0x1f4ee},
            {":potato:",0x1f954},
            {":poultry_leg:",0x1f357},
            {":pout:",0x1f621},
            {":pouting_woman:",0x1f64e},
            {":prayer_beads:",0x1f4ff},
            {":previous_track_button:",0x23ee},
            {":princess:",0x1f478},
            {":punch:",0x1f44a},
            {":purse:",0x1f45b},
            {":put_litter_in_its_place:",0x1f6ae},
            {":question:",0x2753},
            {":rabbit2:",0x1f407},
            {":racing_car:",0x1f3ce},
            {":radio_button:",0x1f518},
            {":rage:",0x1f621},
            {":railway_car:",0x1f683},
            {":rainbow:",0x1f308},
            {":raised_back_of_hand:",0x1f91a},
            {":raised_hand_with_fingers_splayed:",0x1f590},
            {":raising_hand:",0x1f64b},
            {":raising_hand_woman:",0x1f64b},
            {":ramen:",0x1f35c},
            {":record_button:",0x23fa},
            {":red_car:",0x1f697},
            {":registered:",0x00ae},
            {":relieved:",0x1f60c},
            {":repeat:",0x1f501},
            {":rescue_worker_helmet:",0x26d1},
            {":revolving_hearts:",0x1f49e},
            {":rhinoceros:",0x1f98f},
            {":rice:",0x1f35a},
            {":rice_cracker:",0x1f358},
            {":right_anger_bubble:",0x1f5ef},
            {":robot:",0x1f916},
            {":rofl:",0x1f923},
            {":roller_coaster:",0x1f3a2},
            {":rooster:",0x1f413},
            {":rosette:",0x1f3f5},
            {":round_pushpin:",0x1f4cd},
            {":rowing_man:",0x1f6a3},
            {":rugby_football:",0x1f3c9},
            {":running:",0x1f3c3},
            {":running_shirt_with_sash:",0x1f3bd},
            {":sa:",0x1f202},
            {":sailboat:",0x26f5},
            {":sandal:",0x1f461},
            {":sassy_woman:",0x1f481},
            {":satisfied:",0x1f606},
            {":saxophone:",0x1f3b7},
            {":school_satchel:",0x1f392},
            {":scorpion:",0x1f982},
            {":scream:",0x1f631},
            {":scroll:",0x1f4dc},
            {":secret:",0x3299},
            {":seedling:",0x1f331},
            {":shallow_pan_of_food:",0x1f958},
            {":shark:",0x1f988},
            {":sheep:",0x1f411},
            {":shield:",0x1f6e1},
            {":ship:",0x1f6a2},
            {":shirt:",0x1f455},
            {":shoe:",0x1f45e},
            {":shopping_cart:",0x1f6d2},
            {":shrimp:",0x1f990},
            {":signal_strength:",0x1f4f6},
            {":six_pointed_star:",0x1f52f},
            {":skier:",0x26f7},
            {":skull_and_crossbones:",0x2620},
            {":sleeping_bed:",0x1f6cc},
            {":slightly_frowning_face:",0x1f641},
            {":slot_machine:",0x1f3b0},
            {":small_airplane:",0x1f6e9},
            {":small_orange_diamond:",0x1f538},
            {":small_red_triangle_down:",0x1f53b},
            {":smile_cat:",0x1f638},
            {":smiley_cat:",0x1f63a},
            {":smirk:",0x1f60f},
            {":smoking:",0x1f6ac},
            {":snake:",0x1f40d},
            {":snowboarder:",0x1f3c2},
            {":snowman:",0x26c4},
            {":sob:",0x1f62d},
            {":soon:",0x1f51c},
            {":sound:",0x1f509},
            {":space_invader:",0x1f47e},
            {":spaghetti:",0x1f35d},
            {":sparkler:",0x1f387},
            {":sparkling_heart:",0x1f496},
            {":speaker:",0x1f508},
            {":speech_balloon:",0x1f4ac},
            {":spider:",0x1f577},
            {":spiral_calendar:",0x1f5d3},
            {":spoon:",0x1f944},
            {":stadium:",0x1f3df},
            {":star2:",0x1f31f},
            {":star_of_david:",0x2721},
            {":station:",0x1f689},
            {":steam_locomotive:",0x1f682},
            {":stop_button:",0x23f9},
            {":stopwatch:",0x23f1},
            {":strawberry:",0x1f353},
            {":stuck_out_tongue_closed_eyes:",0x1f61d},
            {":studio_microphone:",0x1f399},
            {":sun_behind_large_cloud:",0x1f325},
            {":sun_behind_small_cloud:",0x1f324},
            {":sunflower:",0x1f33b},
            {":sunny:",0x2600},
            {":sunrise_over_mountains:",0x1f304},
            {":surfing_man:",0x1f3c4},
            {":sushi:",0x1f363},
            {":suspension_railway:",0x1f69f},
            {":sweat:",0x1f613},
            {":sweat_smile:",0x1f605},
            {":sweet_potato:",0x1f360},
            {":swimming_man:",0x1f3ca},
            {":symbols:",0x1f523},
            {":syringe:",0x1f489},
            {":tada:",0x1f389},
            {":tanabata_tree:",0x1f38b},
            {":taurus:",0x2649},
            {":tea:",0x1f375},
            {":telephone_receiver:",0x1f4de},
            {":tennis:",0x1f3be},
            {":thermometer:",0x1f321},
            {":thought_balloon:",0x1f4ad},
            {":thumbsdown:",0x1f44e},
            {":ticket:",0x1f3ab},
            {":tiger:",0x1f42f},
            {":timer_clock:",0x23f2},
            {":tipping_hand_woman:",0x1f481},
            {":tm:",0x2122},
            {":toilet:",0x1f6bd},
            {":tokyo_tower:",0x1f5fc},
            {":tongue:",0x1f445},
            {":tophat:",0x1f3a9},
            {":trackball:",0x1f5b2},
            {":traffic_light:",0x1f6a5},
            {":train2:",0x1f686},
            {":triangular_flag_on_post:",0x1f6a9},
            {":trident:",0x1f531},
            {":triumph:",0x1f624},
            {":trophy:",0x1f3c6},
            {":tropical_fish:",0x1f420},
            {":trumpet:",0x1f3ba},
            {":tulip:",0x1f337},
            {":turkey:",0x1f983},
            {":turtle:",0x1f422},
            {":tv:",0x1f4fa},
            {":two_hearts:",0x1f495},
            {":two_women_holding_hands:",0x1f46d},
            {":u5408:",0x1f234},
            {":u6307:",0x1f22f},
            {":u6709:",0x1f236},
            {":u7121:",0x1f21a},
            {":u7981:",0x1f232},
            {":umbrella:",0x2614},
            {":underage:",0x1f51e},
            {":unlock:",0x1f513},
            {":upside_down_face:",0x1f643},
            {":v:",0x270c},
            {":vertical_traffic_light:",0x1f6a6},
            {":vibration_mode:",0x1f4f3},
            {":video_game:",0x1f3ae},
            {":violin:",0x1f3bb},
            {":volcano:",0x1f30b},
            {":vs:",0x1f19a},
            {":walking:",0x1f6b6},
            {":waning_crescent_moon:",0x1f318},
            {":warning:",0x26a0},
            {":watch:",0x231a},
            {":watermelon:",0x1f349},
            {":wavy_dash:",0x3030},
            {":waxing_gibbous_moon:",0x1f314},
            {":weary:",0x1f629},
            {":weight_lifting_man:",0x1f3cb},
            {":whale:",0x1f433},
            {":wheel_of_dharma:",0x2638},
            {":white_check_mark:",0x2705},
            {":white_flag:",0x1f3f3},
            {":white_large_square:",0x2b1c},
            {":white_medium_square:",0x25fb},
            {":white_square_button:",0x1f533},
            {":wind_chime:",0x1f390},
            {":wine_glass:",0x1f377},
            {":wolf:",0x1f43a},
            {":womans_clothes:",0x1f45a},
            {":womens:",0x1f6ba},
            {":worried:",0x1f61f},
            {":writing_hand:",0x270d},
            {":yellow_heart:",0x1f49b},
            {":yen:",0x1f4b4},
            {":yum:",0x1f60b},
            {":zap:",0x26a1},
            {":zipper_mouth_face:",0x1f910},
        };
    }
}