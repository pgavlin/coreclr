using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _ServerModel_servermodel_servermodel_
    {
        [Fact]
        public void _ServerModel_servermodel_servermodel_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\ServerModel\\servermodel\\servermodel.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
