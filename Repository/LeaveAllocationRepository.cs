﻿using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db) {
            _db = db;
        }

        public bool Create(LeaveAllocation entity) {
            _db.leaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity) {
            _db.leaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll() {
            return _db.leaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id) {
            throw new NotImplementedException();
        }

        public bool Save() {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity) {
            _db.leaveAllocations.Update(entity);
            return Save();
        }
    }
}
