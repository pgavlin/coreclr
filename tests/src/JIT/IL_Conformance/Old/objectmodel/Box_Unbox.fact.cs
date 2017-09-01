using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_Box_Unbox_Box_Unbox_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_Box_Unbox_Box_Unbox_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\Box_Unbox\\Box_Unbox.cmd");
        }
    }
}
