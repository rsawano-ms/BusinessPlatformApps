
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RedditCore.DataModel
{

using System;
    using System.Collections.Generic;
    
public partial class Post
{

    public string Id { get; set; }

    public string Content { get; set; }

    public Nullable<int> Gilded { get; set; }

    public string Author { get; set; }

    public string Subreddit { get; set; }

    public Nullable<bool> IsComment { get; set; }

    public Nullable<decimal> Sentiment { get; set; }

    public string Title { get; set; }

    public System.DateTime PublishedTimestamp { get; set; }

    public System.DateTime PublishedMonthPrecision { get; set; }

    public System.DateTime PublishedWeekPrecision { get; set; }

    public System.DateTime PublishedDayPrecision { get; set; }

    public System.DateTime PublishedHourPrecision { get; set; }

    public System.DateTime PublishedMinutePrecision { get; set; }

    public System.DateTime IngestedTimestamp { get; set; }

    public string Url { get; set; }

    public string MediaPreviewUrl { get; set; }

    public Nullable<int> Score { get; set; }

    public Nullable<double> Controversiality { get; set; }

    public Nullable<bool> DocumentContainsUserDefinedEntities { get; private set; }

}

}
