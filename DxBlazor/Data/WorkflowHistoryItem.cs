namespace DxBlazor.Data;

/// <summary>
/// Represents a WorkflowHistoryItem
/// </summary>
public class WorkflowHistoryItem
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

    private int? _WorkflowId;
    /// <summary>
    /// Gets/sets the WorkflowId
    /// </summary>
    public int? WorkflowId
    {
        get => _WorkflowId;
        set => _WorkflowId = value;
    }

    private int? _DocIden;
    /// <summary>
    /// Gets/sets the DocIden
    /// </summary>
    public int? DocIden
    {
        get => _DocIden;
        set => _DocIden = value;
    }

    private string _DocumentTitle;
    /// <summary>Gets or sets the DocumentTitle</summary>
    public string DocumentTitle
    {
        get => _DocumentTitle;
        set => _DocumentTitle = value;
    }

    private string _Data;
    /// <summary>Gets or sets the Data</summary>
    public string Data
    {
        get => _Data;
        set => _Data = value;
    }

    private int? _StateId;
    /// <summary>
    /// Gets/sets the StateId
    /// </summary>
    public int? StateId
    {
        get => _StateId;
        set => _StateId = value;
    }

    private string _State;
    /// <summary>Gets or sets the State</summary>
    public string State
    {
        get => _State;
        set => _State = value;
    }

    private string _Modified;
    /// <summary>Gets or sets the Modified date</summary>
    public string Modified
    {
        get => _Modified;
        set => _Modified = value;
    }

    private int? _UserId;
    /// <summary>
    /// Gets/sets the UserId
    /// </summary>
    public int? UserId
    {
        get => _UserId;
        set => _UserId = value;
    }

    private string _User;
    /// <summary>Gets or sets the User</summary>
    public string User
    {
        get => _User;
        set => _User = value;
    }

    private int? _BinderId;
    /// <summary>
    /// Gets/sets the BinderId
    /// </summary>
    public int? BinderId
    {
        get => _BinderId;
        set => _BinderId = value;
    }
}