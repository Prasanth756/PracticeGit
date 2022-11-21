using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sreerastu_proj.Models;
using Sreerastu_proj.ViewModel;

namespace Sreerastu_proj.Repository
{
    public interface IPostRepository
    {
        Task<TblVendorRegistration> AddVendor(TblVendorRegistration tblVendorRegistration);
        Task<List<TblVendorRegistration>> GetVendor();
        Task<TblVendorRegistration> GetVendorByID(int vendorID);
        Task UpdateVendor(TblVendorRegistration tblVendorRegistration);
        Task<List<TblSubscriptionType>> GetSubscriptionType();
        Task<TblSubscriptionType> GetSubscriptionTypes(int? id);
        Task<List<TblVendorStatus>> GetVendorStatus();
        Task<TblVendorStatus> GetVendorStatusID(int? ID);
        Task<TblSubscriptionType> AddSubscriptionType(TblSubscriptionType AddSubscriptionType);
        Task UpdateSubscriptionType(TblSubscriptionType UpdateSubscriptionType);
        Task<TblVendorStatus> AddVendorStatus(TblVendorStatus AddVendorStatus);
        Task UpdateVendorStatus(TblVendorStatus UpdateVendorStatus);
        Task<int> DeleteSubscriptionType(int? SubscriptionTypeID);
        Task<int> DeleteVendorStatus(int? StatusID);
    }
}
