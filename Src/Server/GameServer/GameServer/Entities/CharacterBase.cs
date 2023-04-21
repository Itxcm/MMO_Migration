﻿using Common.Data;
using GameServer.Core;
using GameServer.Managers;
using SkillBridge.Message;

namespace GameServer.Entities
{
    public class CharacterBase : Entity
    {
        public int Id;// 角色id 数据库中的
        public string Name => Info.Name; //  角色名称

        public CharacterDefine Define; // 角色配置表

        public NCharacterInfo Info; // 角色传输信息

        public CharacterBase(Vector3Int pos, Vector3Int dir) : base(pos, dir)
        {
        }

        public CharacterBase(CharacterType type, int configId, int level, Vector3Int pos, Vector3Int dir) : base(pos, dir)
        {
            Define = DataManager.Instance.Characters[configId];
            Info = new NCharacterInfo
            {
                Type = type,
                Level = level,
                ConfigId = configId,
                Entity = EntityData,
                EntityId = EntityId,
                Name = Define.Name
            };
        }
    }
}