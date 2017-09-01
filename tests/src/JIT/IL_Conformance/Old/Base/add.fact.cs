using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_add_add_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_add_add_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\add\\add.cmd");
        }
    }
}
