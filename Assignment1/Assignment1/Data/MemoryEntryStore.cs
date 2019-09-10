﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment1.Data
{
    public class MemoryEntryStore : INoteEntryStore
    {
        private readonly Dictionary<string, NoteEntry> entries = new Dictionary<string, NoteEntry>();

        public Task AddAsync(NoteEntry entry)
        {
            entries.Add(entry.minutesId, entry);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(NoteEntry entry)
        {
            entries.Remove(entry.minutesId);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<NoteEntry>> GetAllAsync()
        {
            IEnumerable<NoteEntry> result = entries.Values.ToList();
            return Task.FromResult(result);
        }

        public Task<NoteEntry> GetByIdAsync(string id)
        {
            NoteEntry entry = null;
            entries.TryGetValue(id, out entry);
            return Task.FromResult(entry);
        }

        public Task UpdateAsync(NoteEntry entry)
        {
            return Task.CompletedTask;
        }
    }
}