using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Dynamo_dynamo_dynamo_
    {
        [Fact]
        public void _Dynamo_dynamo_dynamo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Dynamo\\dynamo\\dynamo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
