using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _dynamicobjectproperties_TestAPIs_TestAPIs_
    {
        [OuterLoop]
        [Fact]
        public void _dynamicobjectproperties_TestAPIs_TestAPIs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\dynamicobjectproperties\\TestAPIs\\TestAPIs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
