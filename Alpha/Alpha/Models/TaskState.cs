namespace Alpha
{
    public enum TaskState
    {
        /// <summary>
        /// Новая.
        /// </summary>
        New = 0,
    
        /// <summary>
        /// В работе.
        /// </summary>
        InProgress = 1,
    
        /// <summary>
        /// Завершена.
        /// </summary>
        Completed = 2,
    
        /// <summary>
        /// Произошла ошибка.
        /// </summary>
        Error = 3,
    
        /// <summary>
        /// Обучение завершено.
        /// </summary>
        Trained = 4,
    
        /// <summary>
        /// Прекращена.
        /// </summary>
        Aborted = 5
    }
}