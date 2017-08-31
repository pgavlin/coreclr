using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _regression_DDB148379_ddb148379_ddb148379_
    {
        [OuterLoop]
        [Fact]
        public void _regression_DDB148379_ddb148379_ddb148379_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\regression\\DDB148379\\ddb148379\\ddb148379.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
