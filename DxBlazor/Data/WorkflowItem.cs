namespace DxBlazor.Data;

/// <summary>
/// Represents a WorkflowItem
/// </summary>
public class WorkflowItem
{
    private int? _Id;
    /// <summary>
    /// Gets/sets the Id
    /// </summary>
    public int? Id
    {
        get => _Id;
        set => _Id = value;
    }

    private int? _CategoryId;
    /// <summary>
    /// Gets/sets the CategoryId
    /// </summary>
    public int? CategoryId
    {
        get => _CategoryId;
        set => _CategoryId = value;
    }

    private int? _OwnerId;
    /// <summary>
    /// Gets/sets the OwnerId
    /// </summary>
    public int? OwnerId
    {
        get => _OwnerId;
        set => _OwnerId = value;
    }

    private string _OwnerName;
    /// <summary>Gets or sets the OwnerName</summary>
    public string OwnerName
    {
        get => _OwnerName;
        set => _OwnerName = value;
    }

    private string _Name;
    /// <summary>Gets or sets the Name</summary>
    public string Name
    {
        get => _Name;
        set => _Name = value;
    }

    private string _Created;
    /// <summary>Gets or sets the Created date</summary>
    public string Created
    {
        get => _Created;
        set => _Created = value;
    }

    private int? _CurrentStateId;
    /// <summary>
    /// Gets/sets the CurrentStateId
    /// </summary>
    public int? CurrentStateId
    {
        get => _CurrentStateId;
        set => _CurrentStateId = value;
    }

    private string _CurrentState;
    /// <summary>Gets or sets the CurrentState</summary>
    public string CurrentState
    {
        get => _CurrentState;
        set => _CurrentState = value;
    }

    /// <summary>
    /// Gets the History collection
    /// </summary>
    public WorkflowHistoryCollection? History { get; set; }
}
