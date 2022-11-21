using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sreerastu_proj.Models;
using Sreerastu_proj.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Sreerastu_proj.Repository
{
    public class PostRepository:IPostRepository
    {
        SreerastuContext db;
        public PostRepository(SreerastuContext _db)
        {
            db = _db;
        }

        public async Task<TblVendorRegistration> AddVendor(TblVendorRegistration tblVendorRegistration)
        {
            if (db != null)
            {
                await db.TblVendorRegistration.AddAsync(tblVendorRegistration);
                await db.SaveChangesAsync();
                return tblVendorRegistration;
            }
            return null;
        }

        public async Task<TblVendorCategory> AddVendorCategory(TblVendorCategory tblVendorCategory)
        {
            if (db != null)
            {
                await db.TblVendorCategory.AddAsync(tblVendorCategory);
                await db.SaveChangesAsync();
                return tblVendorCategory;
            }
            return null;
        }

        public async Task<List<TblVendorRegistration>> GetVendor()
        {
            if (db != null)
            {
                return await db.TblVendorRegistration.ToListAsync();
            }

            return null;
        }

        public async Task<TblVendorRegistration> GetVendorByID(int vendorID)
        {
            if (db != null)
            {
                return await db.TblVendorRegistration.FindAsync(vendorID);
            }
            return null;
        }
        public async Task UpdateVendor(TblVendorRegistration tblVendorRegistration)
        {
            if (db != null)
            {
                db.TblVendorRegistration.Update(tblVendorRegistration);
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<TblSubscriptionType>> GetSubscriptionType()
        {
            if(db != null)
            {
                return await db.TblSubscriptionType.ToListAsync();
            }
            return null;
        }
        public async Task<TblSubscriptionType> GetSubscriptionTypes(int? id)
        {
            if (db != null)
            {
                return await (from S in db.TblSubscriptionType
                              where S.SubscriptionTypeId == id
                              select new TblSubscriptionType
                              {
                                  SubscriptionTypeId = S.SubscriptionTypeId,
                                  SubscriptionType = S.SubscriptionType,
                                  Amount = S.Amount
                              }).FirstOrDefaultAsync();
            }
            return null;
        
        }
        public async Task<List<TblVendorStatus>> GetVendorStatus()
        {
            if (db != null)
            {
                return await db.TblVendorStatus.ToListAsync();
            }
            return null;
        }
        public async Task<TblVendorStatus> GetVendorStatusID(int? ID)
        {
            if (db != null)
            {
                return await (from V in db.TblVendorStatus
                              where V.StatusId == ID
                              select new TblVendorStatus
                              {
                                  StatusId = V.StatusId,
                                  Status = V.Status
                              }).FirstOrDefaultAsync();
            }
            return null;

        }
        public async Task<TblSubscriptionType>AddSubscriptionType(TblSubscriptionType tblSubscriptionType)
        {
            if (db != null)
            {
                await db.TblSubscriptionType.AddAsync(tblSubscriptionType);
                await db.SaveChangesAsync();
                return tblSubscriptionType;
            }
            return null;
        }
        public async Task UpdateSubscriptionType(TblSubscriptionType tblSubscriptionType)
        {
            if (db != null)
            {
                db.TblSubscriptionType.Update(tblSubscriptionType);
                await db.SaveChangesAsync();
            }
           
        }
        public async Task<int> DeleteSubscriptionType(int? SubscriptionTypeID)
        {
            int result = 0;

            if (db != null)
            {
                var SubscriptionType = await db.TblSubscriptionType.FirstOrDefaultAsync(x => x.SubscriptionTypeId==SubscriptionTypeID);

                if (SubscriptionType != null)
                {

                    db.TblSubscriptionType.Remove(SubscriptionType);
                    result = await db.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }       
        public async Task<TblVendorStatus> AddVendorStatus(TblVendorStatus tblVendorStatus)
        {
            if (db != null)
            {
                await db.TblVendorStatus.AddAsync(tblVendorStatus);
                await db.SaveChangesAsync();
                return tblVendorStatus;
            }
            return null;
        }
        public async Task UpdateVendorStatus(TblVendorStatus tblVendorStatus)
        {
            if (db != null)
            {
                db.TblVendorStatus.Update(tblVendorStatus);
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> DeleteVendorStatus(int? StatusID)
        {
            int result = 0;
            if(db != null)
            {
                var VendorStatus = await db.TblVendorStatus.FirstOrDefaultAsync(x => x.StatusId == StatusID);
                if (VendorStatus != null)
                {
                    db.TblVendorStatus.Remove(VendorStatus);
                    result = await db.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }

    }
}
