using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _dynamicobjectproperties_test448035_test448035_
    {
        [OuterLoop]
        [Fact]
        public void _dynamicobjectproperties_test448035_test448035_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\dynamicobjectproperties\\test448035\\test448035.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
