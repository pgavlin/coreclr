using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_object_ObjectMemberwiseClone_ObjectMemberwiseClone_
    {
        [OuterLoop]
        [Fact]
        public void _system_object_ObjectMemberwiseClone_ObjectMemberwiseClone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\object\\ObjectMemberwiseClone\\ObjectMemberwiseClone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
