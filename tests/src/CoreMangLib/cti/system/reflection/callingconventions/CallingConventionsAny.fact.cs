using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_callingconventions_CallingConventionsAny_CallingConventionsAny_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_callingconventions_CallingConventionsAny_CallingConventionsAny_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\callingconventions\\CallingConventionsAny\\CallingConventionsAny.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
