using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_269336_objmonhelper_objmonhelper_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_269336_objmonhelper_objmonhelper_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\269336\\objmonhelper\\objmonhelper.cmd");
        }
    }
}
