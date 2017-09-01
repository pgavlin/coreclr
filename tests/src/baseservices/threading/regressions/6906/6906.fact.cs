using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_6906_6906_6906_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_6906_6906_6906_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\6906\\6906\\6906.cmd");
        }
    }
}
