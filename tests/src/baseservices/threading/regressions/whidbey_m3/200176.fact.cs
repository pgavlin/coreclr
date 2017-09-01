using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_whidbey_m3_200176_200176_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_whidbey_m3_200176_200176_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\whidbey_m3\\200176\\200176.cmd");
        }
    }
}
