using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_dupi_dupi_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_dupi_dupi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\dupi\\dupi.cmd");
        }
    }
}
