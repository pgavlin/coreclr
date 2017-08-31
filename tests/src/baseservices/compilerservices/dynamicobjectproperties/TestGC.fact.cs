using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _dynamicobjectproperties_TestGC_TestGC_
    {
        [OuterLoop]
        [Fact]
        public void _dynamicobjectproperties_TestGC_TestGC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\dynamicobjectproperties\\TestGC\\TestGC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
