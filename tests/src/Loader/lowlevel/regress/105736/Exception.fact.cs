using CoreclrTestLib;
using Xunit;

namespace Loader_lowlevel
{
    public class _regress_105736_Exception_Exception_
    {
        [OuterLoop]
        [Fact]
        public void _regress_105736_Exception_Exception_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\lowlevel\\regress\\105736\\Exception\\Exception.cmd");
        }
    }
}
