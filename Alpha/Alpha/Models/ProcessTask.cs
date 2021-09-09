using System.ComponentModel.DataAnnotations;

namespace Alpha
{
    public class ProcessTask
    {
        [Key]
        public int TaskId { get; set; }
        
        public int Id => TaskId;
        
        public TaskState State { get; set; }
        
        public ProcessTask()
        {
            State = TaskState.New;
        }
    }
}