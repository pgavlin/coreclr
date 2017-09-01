using CoreclrTestLib;
using Xunit;

namespace baseservices_multidimmarray
{
    public class _rank1array_rank1array_
    {
        [OuterLoop]
        [Fact]
        public void _rank1array_rank1array_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\multidimmarray\\rank1array\\rank1array.cmd");
        }
    }
}
