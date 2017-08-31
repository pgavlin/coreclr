using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_object_ObjectCtor_ObjectCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_object_ObjectCtor_ObjectCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\object\\ObjectCtor\\ObjectCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
