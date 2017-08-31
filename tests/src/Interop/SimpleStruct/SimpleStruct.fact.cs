using CoreclrTestLib;
using Xunit;

namespace Interop_SimpleStruct
{
    class _SimpleStruct_SimpleStruct_
    {
        [OuterLoop]
        [Fact]
        public void _SimpleStruct_SimpleStruct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\SimpleStruct\\SimpleStruct\\SimpleStruct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
