using System.Threading.Tasks;

namespace FaciTech.Apartment.BL
{
    public static class TaskExtension
    {
        public static T Result<T>(this Task<T> task)
        {
            task.Wait();
            return task.Result;
        }
    }
}
