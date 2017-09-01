using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Convert_FPZero_FPZero_
    {
        [OuterLoop]
        [Fact]
        public void _Convert_FPZero_FPZero_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Convert\\FPZero\\FPZero.cmd");
        }
    }
}
