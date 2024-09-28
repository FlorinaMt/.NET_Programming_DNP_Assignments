﻿namespace ApiContracts;

public class GetPostResponse
{
    public required string Title { get; set; }
    public required string Body { get; set; }
    public required string AuthorUsername { get; set; }
    public required int PostId { get; set; }
    public required int LikesNo  { get; set; }
    public required List<GetCommentResponseDto> Comments { get; set; }
}