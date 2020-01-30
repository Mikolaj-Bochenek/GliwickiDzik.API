using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GliwickiDzik.API.Helpers;
using GliwickiDzik.API.Models;
using GliwickiDzik.Data;
using Microsoft.EntityFrameworkCore;

namespace GliwickiDzik.API.Data
{
    public class PlanRepository : GenericRepository<TrainingPlanModel>, IPlanRepository
    {
        public PlanRepository(DataContext dataContext) : base(dataContext) {}
        public async Task<TrainingPlanModel> GetOneTrainingPlanAsync(int trainingPlanId)
        {
            return await _dataContext.TrainingPlanModel.Include(t => t.Trainings)
                .FirstOrDefaultAsync(p => p.TrainingPlanId == trainingPlanId);
        }
        public async Task<PagedList<TrainingPlanModel>> GetAllTrainingPlansAsync(TrainingPlanParams trainingPlanParams)
        {
            var trainingPlans = _dataContext.TrainingPlanModel.Include(p => p.Trainings).OrderByDescending(p => p.LikeCounter);

            if (!string.IsNullOrEmpty(trainingPlanParams.OrderBy))
            {
                switch(trainingPlanParams.OrderBy)
                {
                    case "Newest":
                        trainingPlans = trainingPlans.OrderByDescending(p => p.DateOfCreated);
                        break;
                    
                    case "Oldest":
                        trainingPlans = trainingPlans.OrderBy(p => p.DateOfCreated);
                        break;
                    
                    default:
                        trainingPlans = trainingPlans.OrderByDescending(p => p.LikeCounter);
                        break;
                }
            }
            
             return await PagedList<TrainingPlanModel>.CreateListAsync(trainingPlans, trainingPlanParams.PageSize, trainingPlanParams.PageNumber);
        }
        public async Task<IEnumerable<TrainingPlanModel>> GetAllTrainingPlansForUserAsync(int whoseUserId)
        {
            return await _dataContext.TrainingPlanModel.Where(p => p.UserId == whoseUserId).ToListAsync();
        }
        public async Task<PagedList<TrainingPlanModel>> GetAllTrainingPlansForUserAsync(int whoseUserId, TrainingPlanParams trainingPlanParams)
        {
            var trainingPlans = _dataContext.TrainingPlanModel.Where(p => p.UserId == whoseUserId).Include(p => p.Trainings).OrderByDescending(p => p.LikeCounter);

            if (!string.IsNullOrEmpty(trainingPlanParams.OrderBy))
            {
                switch(trainingPlanParams.OrderBy)
                {
                    case "Newest":
                        trainingPlans = trainingPlans.OrderByDescending(p => p.DateOfCreated);
                        break;
                    
                    case "Oldest":
                        trainingPlans = trainingPlans.OrderBy(p => p.DateOfCreated);
                        break;
                    
                    default:
                        trainingPlans = trainingPlans.OrderByDescending(p => p.LikeCounter);
                        break;
                }
            }
            
             return await PagedList<TrainingPlanModel>.CreateListAsync(trainingPlans, trainingPlanParams.PageSize, trainingPlanParams.PageNumber);
        }

        public async Task<bool> IsTrainingPlanExist(int userId, string trainingPlanName)
        {
            if(await _dataContext.TrainingPlanModel.AnyAsync(p => p.Name == trainingPlanName && p.UserId == userId))
                return true;

            return false;
        }
    }
}