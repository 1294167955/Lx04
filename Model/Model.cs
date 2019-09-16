using System;

namespace Model
{
    public class UserInfo
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public string qq { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string userImg { get; set; }
    }
    public class UserInfoNo : UserInfo
    {
        public int num { get; set; }
    }
    public class Page
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
    public class Activity
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
        public DateTime endTime { get; set; }
        public string activityPicture { get; set; }
        public string activityIntroduction { get; set; }
        public string summary { get; set; }
        public string activityVerify { get; set; }
        public string activityStatus { get; set; }
        public string userName { get; set; }
        public string recommend { get; set; }
        public string recommendTime { get; set; }
    }
    public class WorkInfo
    {
        public int workId { get; set; }
        public string  workName{ get; set; }
        public string workPicture { get; set; }
        public string uploadTime { get; set; }
        public string workIntroducetion { get; set; }
        public string workVerify { get; set; }
        public string userName { get; set; }
        public string activityId { get; set; }
        public string recommend { get; set; }
        public string recommendTime { get; set; }
}
    public class Comment
    {
        public int commentId { get; set; }
        public int workID { get; set; }
        public string userName { get; set; }
        public int commentContent { get; set; }
        public DateTime commentTime { get; set; }
    }
    public class WorkFindPage : Page
    {
        public string workName { get; set; }
    }
    public class WorkMyPage : Page
    {
        public string userName { get; set; }
    }
    public class CommentPage : Page
    {
        public string workId { get; set; }
    }
    public class ActivityNo : Activity
    {
        public int num { get; set; }
    }
    public class ActivityName
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
    }
    public class WorkInfoNo : WorkInfo
    {
        public int num { get; set; }
        public string activityName { get; set; }
    }
    public class CommentNo : Comment
    {
        public int num { get; set; }
        public string workName { get; set; }
    }
}
