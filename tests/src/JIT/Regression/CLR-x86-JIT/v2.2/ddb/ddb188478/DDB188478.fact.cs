using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_2_ddb_ddb188478_DDB188478_DDB188478_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_2_ddb_ddb188478_DDB188478_DDB188478_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.2\\ddb\\ddb188478\\DDB188478\\DDB188478.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
