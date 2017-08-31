using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_callingconventions_CallingConventionsVarArgs_CallingConventionsVarArgs_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_callingconventions_CallingConventionsVarArgs_CallingConventionsVarArgs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\callingconventions\\CallingConventionsVarArgs\\CallingConventionsVarArgs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
