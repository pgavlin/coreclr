using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_enum_enum_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_enum_enum_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\enum\\enum.cmd");
        }
    }
}
