namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddUpvote
    /// </summary>
    public class AddUpvoteInput
    {
        /// <summary>
        /// The Node ID of the discussion or comment to upvote.
        /// </summary>
        public ID SubjectId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}