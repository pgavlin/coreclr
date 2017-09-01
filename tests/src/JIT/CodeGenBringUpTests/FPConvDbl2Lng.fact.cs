using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPConvDbl2Lng_FPConvDbl2Lng_
    {
        [OuterLoop]
        [Fact]
        public void _FPConvDbl2Lng_FPConvDbl2Lng_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPConvDbl2Lng\\FPConvDbl2Lng.cmd");
        }
    }
}
