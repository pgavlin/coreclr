using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_i_add_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_add_i_add_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_i\\add_i.cmd");
        }
    }
}
