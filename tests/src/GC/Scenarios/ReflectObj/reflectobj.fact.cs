using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _ReflectObj_reflectobj_reflectobj_
    {
        [Fact]
        public void _ReflectObj_reflectobj_reflectobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\ReflectObj\\reflectobj\\reflectobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
