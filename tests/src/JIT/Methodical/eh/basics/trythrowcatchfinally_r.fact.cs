using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trythrowcatchfinally_r_trythrowcatchfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trythrowcatchfinally_r_trythrowcatchfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trythrowcatchfinally_r\\trythrowcatchfinally_r.cmd");
        }
    }
}
