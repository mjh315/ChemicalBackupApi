using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


public class AddTableReqDto
{
    [JsonPropertyName("adminId")]
    public int AdminId { get; set; }
    [JsonPropertyName("backupId")]
    public Guid BackupId { get; set; }
    [JsonPropertyName("tableName")]
    public string TableName { get; set; }
    [JsonPropertyName("requestData")]
    public List<object> RequestData { get; set; }
}

