﻿using Serenity.Data;

namespace Serenity.Services
{
    public abstract class BaseSaveBehavior : ISaveBehavior
    {
        public virtual void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query)
        {
        }

        public virtual void OnAfterSave(ISaveRequestHandler handler)
        {
        }

        public virtual void OnBeforeSave(ISaveRequestHandler handler)
        {
        }

        public virtual void OnAudit(ISaveRequestHandler handler)
        {
        }

        public virtual void OnReturn(ISaveRequestHandler handler)
        {
        }

        public virtual void OnSetInternalFields(ISaveRequestHandler handler)
        {
        }

        public virtual void OnValidateRequest(ISaveRequestHandler handler)
        {
        }
    }
}