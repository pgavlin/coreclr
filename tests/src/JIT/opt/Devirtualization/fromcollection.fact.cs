using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_fromcollection_fromcollection_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_fromcollection_fromcollection_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\fromcollection\\fromcollection.cmd");
        }
    }
}
