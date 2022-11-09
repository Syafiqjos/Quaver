namespace Quaver.Shared.Screens.Edit.Actions
{
    public enum EditorActionType
    {
        None = -1,
        PlaceHitObject,
        RemoveHitObject,
        ResizeLongNote,
        RemoveHitObjectBatch,
        PlaceHitObjectBatch,
        FlipHitObjects,
        MoveHitObjects,
        AddHitsound,
        RemoveHitsound,
        CreateLayer,
        RemoveLayer,
        RenameLayer,
        MoveToLayer,
        ColorLayer,
        ToggleLayerVisibility,
        AddScrollVelocity,
        RemoveScrollVelocity,
        AddScrollVelocityBatch,
        RemoveScrollVelocityBatch,
        AddTimingPoint,
        RemoveTimingPoint,
        AddTimingPointBatch,
        RemoveTimingPointBatch,
        ChangePreviewTime,
        ChangeTimingPointOffset,
        ChangeTimingPointBpm,
        ChangeTimingPointSignature,
        ChangeTimingPointHidden,
        ResetTimingPoint,
        ChangeTimingPointBpmBatch,
        ChangeTimingPointSignatureBatch,
        ChangeTimingPointOffsetBatch,
        ChangeScrollVelocityOffsetBatch,
        ChangeScrollVelocityMultiplierBatch,
        ApplyOffset,
        ResnapHitObjects,
        Batch
    }
}