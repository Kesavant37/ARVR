using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------
// Node C# class - User Facing
//--------------------------------------

namespace DialogueEditor
{
    public abstract class ConversationNode
    {
        public enum eNodeType
        {
            Speech,
            Option
        }

        public ConversationNode()
        {
            Connections = new List<Connection>();
            ParamActions = new List<SetParamAction>();
        }

        public abstract eNodeType NodeType { get; }
        public Connection.eConnectionType ConnectionType
        {
            get
            {
                if (Connections.Count > 0)
                    return Connections[0].ConnectionType;
                return Connection.eConnectionType.None;
            }
        }

        public string Text;

        public List<Connection> Connections;

        public List<SetParamAction> ParamActions;

        public TMPro.TMP_FontAsset TMPFont;
    }


    public class SpeechNode : ConversationNode
    {
        public override eNodeType NodeType { get { return eNodeType.Speech; } }

        public string Name;

        public bool AutomaticallyAdvance;

        public bool AutoAdvanceShouldDisplayOption;

        public float TimeUntilAdvance;

        public Sprite Icon;

        public AudioClip Audio;
        public float Volume;

        public UnityEngine.Events.UnityEvent Event;
    }


    public class OptionNode : ConversationNode
    {
        public override eNodeType NodeType { get { return eNodeType.Option; } }

        public UnityEngine.Events.UnityEvent Event;
    }
}
