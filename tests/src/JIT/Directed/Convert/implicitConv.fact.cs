using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Convert_implicitConv_implicitConv_
    {
        [OuterLoop]
        [Fact]
        public void _Convert_implicitConv_implicitConv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Convert\\implicitConv\\implicitConv.cmd");
        }
    }
}
