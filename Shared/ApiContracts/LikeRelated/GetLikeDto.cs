﻿namespace ApiContracts.LikeRelated;

public class GetLikeDto
{
    public required int LikeId { get; set; }
    public required string Username { get; set; }
    public required int PostId { get; set; }
}