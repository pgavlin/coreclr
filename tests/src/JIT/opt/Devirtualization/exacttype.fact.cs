using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_exacttype_exacttype_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_exacttype_exacttype_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\exacttype\\exacttype.cmd");
        }
    }
}
