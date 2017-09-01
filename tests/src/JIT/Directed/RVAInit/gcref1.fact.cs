using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_gcref1_gcref1_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_gcref1_gcref1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\gcref1\\gcref1.cmd");
        }
    }
}
