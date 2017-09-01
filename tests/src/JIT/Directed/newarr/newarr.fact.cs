using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _newarr_newarr_newarr_
    {
        [Fact]
        public void _newarr_newarr_newarr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\newarr\\newarr\\newarr.cmd");
        }
    }
}
