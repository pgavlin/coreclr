using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_popi_popi_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_popi_popi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\popi\\popi.cmd");
        }
    }
}
