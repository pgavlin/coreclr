using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_sharedoverride_sharedoverride_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sharedoverride_sharedoverride_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sharedoverride\\sharedoverride.cmd");
        }
    }
}
