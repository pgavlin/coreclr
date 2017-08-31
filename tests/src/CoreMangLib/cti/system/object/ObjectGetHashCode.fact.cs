using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_object_ObjectGetHashCode_ObjectGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_object_ObjectGetHashCode_ObjectGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\object\\ObjectGetHashCode\\ObjectGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
