using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Gcd_Gcd_
    {
        [OuterLoop]
        [Fact]
        public void _Gcd_Gcd_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Gcd\\Gcd.cmd");
        }
    }
}
