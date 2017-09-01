using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stloc_i8_stloc_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stloc_i8_stloc_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stloc_i8\\stloc_i8.cmd");
        }
    }
}
