using CoreclrTestLib;
using Xunit;

namespace baseservices_multidimmarray
{
    class _rank1array_rank1array_
    {
        [OuterLoop]
        [Fact]
        public void _rank1array_rank1array_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\multidimmarray\\rank1array\\rank1array.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
