using Examine.Presentation.Tags;

namespace Examine.Presentation.Controls
{
    public enum ButtonType
    {
        Default,
        Primary,
        Secondary,
        Success,
        Info,
        Warning,
        Danger,
        Link
    }

    public enum ButtonSize
    {
        Large,
        Small
    }

    public class Button : Tags.Button, IDropdownElement
    {
        public Button(ButtonType type, params BodyElement[] content) : base(Tags.ButtonType.Button, content)
        {
            this.Class("btn");
            this.Class("btn-" + type.AsKebab());            
        }

        public Button(ButtonType type, ButtonSize size, params BodyElement[] content) : base(Tags.ButtonType.Button, content)
        {
            this.Class("btn");
            this.Class("btn-" + type.AsKebab());

            switch (size)
            {
                case ButtonSize.Small:
                    this.Class("btn-sm");
                    break;
                case ButtonSize.Large:
                    this.Class("btn-lg");
                    break;
            }    
        }
    }

    public class BlockButton : Button
    {
        public BlockButton(ButtonType type, params BodyElement[] content) : base (type, content)
        {
            this.Class("btn-block");            
        }

        public BlockButton(ButtonType type, ButtonSize size, params BodyElement[] content) : base (type, size, content)
        {
            this.Class("btn-block");            
        }
    }

    public class OutlineButton : Tags.Button
    {
        public OutlineButton(ButtonType type, params BodyElement[] content) 
            : base(Tags.ButtonType.Button, content)
        {
            this.Class("btn");
            this.Class("btn-outline-" + type.AsKebab());            
        }

        public OutlineButton(ButtonType type, ButtonSize size, params BodyElement[] content) 
            : base(Tags.ButtonType.Button, content)
        {
            this.Class("btn");
            this.Class("btn-outline-" + type.AsKebab());            

            switch (size)
            {
                case ButtonSize.Small:
                    this.Class("btn-sm");
                    break;
                case ButtonSize.Large:
                    this.Class("btn-lg");
                    break;
            }    
        }
    }
    
    public static partial class Fluent
    {
        public static Button Button(ButtonType type, params BodyElement[] content) => new Button(type, content);

        public static Button PrimaryButton(params BodyElement[] content) => new Button(ButtonType.Primary, content);
               
        public static Button SecondaryButton(params BodyElement[] content) => new Button(ButtonType.Secondary, content);

        public static Button SuccessButton(params BodyElement[] content) => new Button(ButtonType.Success, content);

        public static Button DangerButton(params BodyElement[] content) => new Button(ButtonType.Danger, content);

        public static Button InfoButton(params BodyElement[] content) => new Button(ButtonType.Info, content);

        public static Button WarningButton(params BodyElement[] content) => new Button(ButtonType.Warning, content);

        public static Button Button(ButtonType type, ButtonSize size, params BodyElement[] content) => new Button(type, size, content);
               
        public static BlockButton BlockButton(ButtonType type, ButtonSize size, params BodyElement[] content) => new BlockButton(type, size, content);
               
        public static BlockButton BlockButton(ButtonType type, params BodyElement[] content) => new BlockButton(type, content);
               
        public static OutlineButton OutlineButton(ButtonType type, params BodyElement[] content) => new OutlineButton(type, content);
               
        public static OutlineButton OutlineButton(ButtonType type, ButtonSize size, params BodyElement[] content) => new OutlineButton(type, size, content);
    }
}