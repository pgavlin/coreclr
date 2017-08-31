using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _dynamicobjectproperties_TestOverrides_TestOverrides_
    {
        [OuterLoop]
        [Fact]
        public void _dynamicobjectproperties_TestOverrides_TestOverrides_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\dynamicobjectproperties\\TestOverrides\\TestOverrides.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
