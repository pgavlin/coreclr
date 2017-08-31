using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _dynamicobjectproperties_Dev10_535767_Dev10_535767_
    {
        [OuterLoop]
        [Fact]
        public void _dynamicobjectproperties_Dev10_535767_Dev10_535767_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\dynamicobjectproperties\\Dev10_535767\\Dev10_535767.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
